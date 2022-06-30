using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WpfZad3MustBeCorrect
{
    public class PersonModel :ObesrvableObject
    {
        private string _name;
        private string[] _names;
        private string _firstName;
        private string _secondName;
        private string _lastName;
        private string _age;

       

      

        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                string val = _age;
                int aflag =2022 - Convert.ToInt32(_age.Substring(_age.Length - 4));
                _age = aflag.ToString();
                
                OnPropertyChanged();
                _age = val;
            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                OnPropertyChanged();
            }

        }
      

        public string [] Names
        {
            get { return _names; }
            set { _names = value; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _names = _name.Split(' ');
                if (Names.Length < 3)
                {
                    FirstName = Names[0];
                    LastName = Names[1];
                }
                else
                {
                    
                            FirstName = Names[0];
                            SecondName = Names[1];
                            LastName = Names[2];
                      

                }
              
                OnPropertyChanged();
           
                
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
           
                _lastName = value;
                OnPropertyChanged();
               
            }
            
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
              
                _firstName = value;
                OnPropertyChanged();
               
            }
        }
    }
}
