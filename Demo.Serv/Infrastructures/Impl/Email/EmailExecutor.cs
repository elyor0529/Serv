using System;
using System.Configuration;
using System.Net.Mail;
using System.Threading.Tasks;
using Demo.Serv.Logs;
using Demo.Serv.Models;
using Demo.Serv.Repository;
using Newtonsoft.Json;
using SendGrid;

namespace Demo.Serv.Infrastructures.Impl.Email
{
    public class EmailExecutor : IExecutor
    {

        private readonly Tasks _tasks;

        public EmailExecutor(Tasks tasks)
        {
            if (tasks == null)
                throw new ArgumentNullException("tasks");

            _tasks = tasks;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IRepository Repository { get; set; }

        public async Task<object> Run()
        {
            try
            {
                var args = JsonConvert.DeserializeObject<EmailArg>(_tasks.JSONParams);
                var message = new SendGridMessage();
                {
                    message.AddTo(args.Recipiend);
                    message.From = new MailAddress(Properties.Settings.Default.AdminEmail);
                    message.Subject = args.Subject;
                    message.Text = args.Body;
                    message.Html = args.Body;


                    //disable transfering logs  
                    message.DisableClickTracking();
                }

                // Create a Web transport for sending email. 
                var transportWeb = new Web(ConfigurationManager.AppSettings["SendGridKey"]);

                // Send the email.
                await transportWeb.DeliverAsync(message);

                _tasks.Status = OperationStatus.Done;
            }
            catch (Exception exception)
            {
                Log4NetManager.Error(exception.ToString());

                _tasks.Status = OperationStatus.Fealed;
            }

            await Repository.Save(_tasks);

            return Task.FromResult(_tasks);
        }
    }
}
