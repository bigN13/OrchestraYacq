using OrchestraYacq.Common;
using OrchestraYacq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OrchestraYacq
{
    public class MainWindowViewModel : BaseClass
    {
        public MainWindowViewModel()
        {
            SampleData.Seed();

            persons = SampleData.Persons;  
        }

        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set { persons = value; OnPropertyChanged("Persons"); }
        }


    }
}
