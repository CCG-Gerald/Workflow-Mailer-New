using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace CCGMailerService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Mailer>(s =>
                {
                    s.ConstructUsing(mailer => new Mailer());
                    s.WhenStarted(mailer => mailer.Start());
                    s.WhenStopped(mailer => mailer.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("CCGWorkflowMailerService");
                x.SetDisplayName("CCG WorkflowMailer Service");
                x.SetDescription("This is an emailing Service used to send emails from various CCG Systems Modules.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
