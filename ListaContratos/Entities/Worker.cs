using System;
using System.Collections.Generic;
using ListaContratos.Entities;


namespace ListaContratos.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level {get; set; }              //* Associação com outras classes
        public double BaseSalary { get; set; }
        public Department Department { get; set; }         //* Associação com outras classes
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)       //* Para adicionar a Lista
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)    //* Para remove a Lista
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)       //* Calcular quanto o funcionário ganhou    
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}