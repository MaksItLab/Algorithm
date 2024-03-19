using System;
using System.Collections.Generic;

namespace Algorithm
{
    /// <summary>
    /// Генетический алгоритм
    /// </summary>
    public class GeneticAlgorithm
    {

        Random random = new Random();
        /// <summary>
        /// Количество поколений
        /// </summary>
        private int _generations;
        /// <summary>
        /// Количество особей
        /// </summary>
        private int _populationSize;
        /// <summary>
        /// Вероятность мутации
        /// </summary>
        private double _mutationRate;
        /// <summary>
        /// Длина генома (длина массива, количество ген)
        /// </summary>
        private int _genomeLength;
        /// <summary>
        /// Функция приспособленности (Целевая функция)
        /// </summary>
        Func<double[], double> _fitnessFunction;

        public GeneticAlgorithm(int genomeLength, 
                                int populationSize, 
                                int generations, 
                                double mutationRate, 
                                Func<double[],double> fitnessFunction)
        {
            _generations = generations;
            _genomeLength = genomeLength;
            _populationSize = populationSize;
            _mutationRate = mutationRate;
            _fitnessFunction = fitnessFunction;
        }
        /// <summary>
        /// Запуск алгоритма
        /// </summary>
        /// <returns></returns>
        public double[] Run()
        {
            List<double[]> population = GeneratePopulation();

            for (int generation = 0; generation < _generations; generation++)
            {

            }

            return null;
        }
        /// <summary>
        /// Генерация поколения
        /// </summary>
        /// <returns></returns>
        public List<double[]> GeneratePopulation()
        {
            List<double[]> population = new List<double[]>();

            for (int i = 0; i < _populationSize; i++)
            {
                double[] genom = new double[_genomeLength];
                for (int j = 0; j < _genomeLength; j++)
                {
                    genom[j] = random.NextDouble();
                }
                population.Add(genom);
            }

            return population;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            int generations = 100;
            int populationSize = 500;
            double mutationRate = 0.01;
            int genomeLength = 3;

            Func<double[], double> fitnessFunction = (genome) =>
            {
                double sum = 0;
                foreach (var item in genome)
                {
                    sum += item;
                }

                return sum;
            };

            GeneticAlgorithm ga = new GeneticAlgorithm(genomeLength, 
                                                       populationSize, 
                                                       generations, 
                                                       mutationRate, 
                                                       fitnessFunction);
            double[] result = ga.Run();
            Console.WriteLine("Best solution: ");
            foreach (var gen in result)
            {
                Console.Write(gen + " ");
            }
        }
    }
}
