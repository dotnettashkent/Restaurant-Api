using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using Restaurant.Domain.Entities;
using StackExchange.Redis;

namespace Restaurant.Service.Helpers
{
    public class EmailVerification
    {
        private readonly IConfiguration configuration;
        public EmailVerification(IConfiguration configuration)
        {
            this.configuration = configuration.GetSection("Email");
        }

        public async Task<string> SendAsync(User user)
        {
            try
            {
                var random = new Random();
                int verificationCode = random.Next(1000, 9999);

                ConnectionMultiplexer resdisConnect = ConnectionMultiplexer.Connect("localhost");
                IDatabase db = resdisConnect.GetDatabase();
                db.StringSet("code", verificationCode.ToString());
                var result = db.StringGet("code");

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(this.configuration["EmailAddress"]));
                email.To.Add(MailboxAddress.Parse(user.Email));
                email.Subject = "Email verification RestaurantEda.com";
                email.Body = new TextPart(TextFormat.Html) { Text = result.ToString() };

                var sendMessage = new MailKit.Net.Smtp.SmtpClient();
                await sendMessage.ConnectAsync(this.configuration["Host"], 587, SecureSocketOptions.StartTls);
                await sendMessage.AuthenticateAsync(this.configuration["EmailAddress"], this.configuration["Password"]);
                await sendMessage.SendAsync(email);
                await sendMessage.DisconnectAsync(true);

                return result.ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
