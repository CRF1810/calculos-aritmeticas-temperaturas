﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa as operações de conversão de temperatura
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius

        }

        /// <summary>
        /// Tipo de conversão de distancia a executar
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros

        }


        /// <summary>
        /// Conversão de Temperaturas
        /// </summary>
        /// <param name="conversao">Conversão a efetuar</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {

            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {

                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {

                return (temperatura - 32) / 1.8000;
            }
            return -1;
        }

        /// <summary>
        /// Conversão de Distancias
        /// </summary>
        /// <param name="conversao">Conversão a efetuar</param>
        /// <param name="distancia">Distancia a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>

        public static double ConverterDistancia(ConversaoDistancia conversao, double distancia)
        {

            if (conversao == ConversaoDistancia.MetrosMilhas)
            {

                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {

                return distancia * 1609.344;
            }
            return -1;
        }
    }
}
