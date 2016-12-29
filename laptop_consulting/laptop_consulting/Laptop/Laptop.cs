using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Resuilt.Laptop
{
    class Laptop
    {
        private int _id;
        private string _name;
        private float _price;
        private string _reviews;
        private string _detail_decription;
        private string _pros;
        private string _cons;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Reviews
        {
            get
            {
                return _reviews
            }

            set
            {
                _reviews= value;
            }
        }

        public string Detail_decription
        {
            get
            {
                return _detail_decription;
            }

            set
            {
                _detail_decription = value;
            }
        }

        public string Pros
        {
            get
            {
                return _pros;
            }

            set
            {
                _pros = value;
            }
        }

        public  string Cons
        {
            get
            {
                return _cons;
            }

            set
            {
                _cons= value;
            }
        }


    }
}
