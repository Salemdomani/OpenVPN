using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Renci.SshNet;

namespace OpenVPN
{
    public class Server
    {
        public string IP { get; set; }
        public bool IsConnected { get; set; }
        public SshClient ssh { get; set; }
        public SftpClient sftp { get; set; }

        public Server(string ip,string username,string password)
        {
            IP = ip;
            ssh = new SshClient(ip, username, password);
            sftp = new SftpClient(ip, username, password);
        }

        public void Connect()
        {
            ssh.Connect();
            sftp.Connect();
            IsConnected = true;
        }

        public void Disconnect()
        {
            ssh.Disconnect();
            sftp.Disconnect();
            IsConnected = false;
        }

        public void MakeUser(User user)
        {
            var modes = new Dictionary<Renci.SshNet.Common.TerminalModes, uint>();
            using (var stream = ssh.CreateShellStream("xterm", 255, 50, 800, 600, 1024, modes))
            {
                stream.Write("cd /etc/openvpn/easy-rsa\n");
                stream.Write("./easyrsa build-client-full " + user.name + "\n");
                stream.Expect("pass");
                stream.Write(user.pass + "\n");
                stream.Expect("pass");
                stream.Write(user.pass + "\n");
                Thread.Sleep(3000);
                stream.Write("./easyrsa gen-crl\n");
            }
            Thread.Sleep(24000);
            ssh.RunCommand("cp /etc/openvpn/easy-rsa/pki/private/" + user.name + ".key /etc/openvpn/server/private/");
            ssh.RunCommand("cp /etc/openvpn/easy-rsa/pki/issued/" + user.name + ".crt /etc/openvpn/server/issued/");
            var key = sftp.ReadAllText("/etc/openvpn/server/private/" + user.name + ".key");
            var cert = sftp.ReadAllText("/etc/openvpn/server/issued/" + user.name + ".crt");
            var db = new OpenVPNDataClassesDataContext();
            db.Accounts.InsertOnSubmit(new Account()
            {
                Username = user.name,
                Password = user.pass,
                Server = IP,
                _Key = key,
                Certificate = cert
            });
            db.SubmitChanges();
        }
    }
}
