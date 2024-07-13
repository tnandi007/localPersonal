using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    /// <summary>
    /// 1) A manager is a type of employee. --> Inheritence (IS-A relationship)
    /// 2) A manager has a swipe card to enter the company premises. --> Asscociation (HAS-A relationship) --> 1. Aggregation 2. Composition
    ///3) A manager has many workers under him. --> Aggregation
    ///4) The salary of a manager depends on project success.
    ///5) A project success depends on a manager.--> Compostion (refernce class cant exists without container class)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager();
            //Project proj = new Project(mgr);
            //proj.issuccess = true;
            mgr.HowIsTheManager(true);
            double salary = mgr.salary;
        }

    }

    class Manager
    {
        public Project project;
        private string name;
        public double salary;

        public List<Worker> workers = new List<Worker>();// aggregation

        public Manager()
        {
            project = new Project(this);//composition
        }

        public Manager(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void HowIsTheManager(bool good)
        {
            if (good)
            {
                project.IsSuccess = true;

            }
            else
            {
                project.IsSuccess = false;
            }

        }


    }

    class Project
    {
        private Manager manager;
        public bool issuccess = false;

        public Project(Manager manager) //composition
        {
            this.manager = manager;
        }

        public bool IsSuccess {
            get { return issuccess; }
            set { issuccess = value;
                if (value)
                {
                    this.manager.salary++;
                }
                else
                {
                    this.manager.salary--;
                }
            }
        }

    }

    class Worker
    {
        private string name;
        public Worker(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
    }


}
