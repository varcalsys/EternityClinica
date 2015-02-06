using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EterniyClinica.Domain
{
    public class SendMail
    {
        const string nomeRemetente = "Eternity Clinica";
        const string emailRemetente = "eternityclinica@eternityclinica.com";
        const string senha = "admin@123";
        const string SMTP = "webmail.eternityclinica.com";
        
        
        string emailDestinatario = "";

        //Cria objeto com os dados do SMTP
        SmtpClient objSmtp = new SmtpClient();        
        NetworkCredential credentials = new NetworkCredential(emailRemetente, senha);
        public void EnviarEmail(Contato contato)
        {
            const string assuntoMensagem = "Recebimento Confirmado";
            string conteudoMensagem = "A "+nomeRemetente+" agradece seu contato, " + contato.Nome + " <br/><br/> Seu email foi encaminhado para o setor responsável com sucesso" +
                                     " <br/> Retornaremos o contato o mais breve possível" +
                                     " <br/><br/> Obrigado" +
                                     " <br/> " + nomeRemetente;

            emailDestinatario = contato.Email;
            //Criacao do email
            var objEmail = new MailMessage();
            objEmail.From = new MailAddress(nomeRemetente + "<" + emailRemetente + ">");
            objEmail.To.Add(emailDestinatario);
            objEmail.Priority = MailPriority.Normal;
            objEmail.IsBodyHtml = true;
            objEmail.Subject = assuntoMensagem;
            objEmail.Body = conteudoMensagem;
            //Evitar caracteres estranhos
            objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = credentials;
            objSmtp.Host = SMTP;
            objSmtp.Port = 587;
                //objSmtp.EnableSsl = true;

            Enviar(objEmail);
        }
        public void EnviaEmailResponsavel(Contato contato)
        {
            
            //Criacao do email
            var objEmail = new MailMessage();
            objEmail.From = new MailAddress(nomeRemetente + "<" + emailRemetente + ">");
            objEmail.To.Add("contato@eternityclinica.com");
            objEmail.Priority = MailPriority.Normal;
            objEmail.IsBodyHtml = true;
            objEmail.Subject = contato.Assunto + "( Enviada pelo Site)";
            objEmail.Body = contato.Comentario;
            //Evitar caracteres estranhos
            objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = credentials;
            objSmtp.Host = SMTP;
            objSmtp.Port = 587;
            //objSmtp.EnableSsl = true;

           Enviar(objEmail);         
        }


        private void Enviar(MailMessage objEmail)
        {
            try
            {
                objSmtp.Send(objEmail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //excluímos o objeto de e-mail da memória
                objEmail.Dispose();
                //anexo.Dispose();
            }
        }        
    }
}
