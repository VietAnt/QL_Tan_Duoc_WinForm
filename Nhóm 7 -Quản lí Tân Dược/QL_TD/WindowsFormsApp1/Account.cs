using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Account
    {
        private string userName;
        private string passWord;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        //---contrcutor---//
       public Account(string userName, string passWord)
        {
           this.userName = userName;
            this.passWord = passWord;
        }
        

    }

   
   


}
