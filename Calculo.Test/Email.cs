using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculo.Test
{
    public class Email
    {
        public bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.Contains(".");
            }
            catch
            {
                return false;
            }
        }
    }

    public class EmailTest
    {
        private readonly Email _emailValidator;

        public EmailTest()
        {
            _emailValidator = new Email();
        }

        [Theory]
        [InlineData("teste@gmail.com", true)]
        [InlineData("teste.gmail.com", false)]
        [InlineData("teste@gmail", false)]
        [InlineData("teste@", false)]
        [InlineData("teste@.com", false)]
        public void ValidarEmailTest(string email, bool expected)
        {
            bool result = _emailValidator.ValidarEmail(email);
            Assert.Equal(expected, result);
        }
    }
}
