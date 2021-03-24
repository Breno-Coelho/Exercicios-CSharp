using Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public float BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, float baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract a)
        {
            Contracts.Add(a);
        }

        public void RemoveContract(HourContract a) {
            Contracts.Remove(a);
        }

        public float Income(int year, int month)
        {
            float soma = BaseSalary;
            foreach (var i in Contracts)
            {
                if (i.Date.Month == month && i.Date.Year == year)
                {
                    soma += i.TotalValue();
                }
            }
            return soma;
        }
    }
}
