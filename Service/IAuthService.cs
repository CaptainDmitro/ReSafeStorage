using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Renci.SshNet;

namespace ReSafeStorage.Service;

public interface IAuthService
{
    public void SignIn(string userName, string password);
    public void SignUp(string userName, string password);
}

public class AuthService : IAuthService
{
    public void SignIn(string userName, string password)
    {
        try
        {
            var connectionInfo = new ConnectionInfo(
                "127.0.0.1",
                userName,
                new PasswordAuthenticationMethod(userName, password)
            );
            var client = new SftpClient(connectionInfo);
            client.Connect();
            // Hide();
            // new ControlWindow(client, CryptoSystem.GenerateKey(Encoding.UTF8.GetBytes(PasswordBox_Password.Password))).Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        };
    }

    public void SignUp(string userName, string password)
    {
        if (userName.Length == 0)
        {
            Console.WriteLine("Empty username");
        }
        else if (password.Length == 0)
        {
            Console.WriteLine("Empty password");
        }
        else
        {
            try
            {
                SshClient client = new SshClient("127.0.0.1", 22, "", "");
                client.Connect();

                IDictionary<Renci.SshNet.Common.TerminalModes, uint> modes = new Dictionary<Renci.SshNet.Common.TerminalModes, uint>();
                modes.Add(Renci.SshNet.Common.TerminalModes.ECHO, 53);

                ShellStream shellStream = client.CreateShellStream("xterm", 80, 24, 800, 600, 1024, modes);
                var output = shellStream.Expect(new Regex(@"[$>]"));

                shellStream.WriteLine($"{"regscript.sh"} {userName} {password}");
                output = shellStream.Expect(new Regex(@"([$#>:])"));
                shellStream.WriteLine("KEY");
                output = shellStream.Expect(new Regex(@"([$#>:])"));

                client.Disconnect();

                Console.WriteLine("Successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}