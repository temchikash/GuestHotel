using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHotel
{
    internal class People
    {
        public int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string fcs;
        public string FCs
        {
            get
            {
                return fcs;
            }
            set
            {
                fcs = value;
            }
        }   
        public int week;
        public int Week
        {
            get
            {
                return week;
            }
            set
            {
                week = value;
            }
        }
        public string come;
        public string Come
        {
            get
            {
                return come;
            }
            set
            {
                come = value;
            }
        }
       
        public int smacker;
        public int Smacker
        {
            get
            {
                return smacker;
            }
            set
            {
                smacker = value;
            }
        }
        public string birthday;
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int animalsFlag;
        public int FlagAnimals
        {
            get
            {
                return animalsFlag;
            }
            set
            {
                animalsFlag = value;
            }
        }
        public People(string FCS, string birthday, int money, int days, int FlagAnimals)
        {
            fcs = FCS;
            this.birthday = birthday;
            this.smacker = money;
            this.week = days;
            animalsFlag = FlagAnimals;
        }
        public People(int id, string fcS, int money, int days, int WithAnimals)
        {
            fcs = fcS;
            this.smacker = money;
            this.week = days;
            animalsFlag = WithAnimals;
        }
        public People()
        {

        }
    }

}
