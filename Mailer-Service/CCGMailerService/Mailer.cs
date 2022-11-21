using CCGMailerService.BusinessLogic;
using CCGMailerService.Models.Custom;
using CCGMailerService.Models.Tables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CCGMailerService
{
    public class Mailer
    {
        private readonly Timer _timer;
        public string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString;

        public Mailer()
        {
            LogicRepository logicRepository = new LogicRepository();
            logicRepository.connectionString = ConnectionString;

            int milliseconds = logicRepository.ConvertSecondsToMilliseconds();

            _timer = new Timer(milliseconds) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            LogicRepository logicRepository = new LogicRepository();
            logicRepository.connectionString = ConnectionString;

            try
            {
                // MAILER METHOD
                logicRepository.SendEmail();
            }
            catch (Exception ex)
            {

            }

        }


        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
