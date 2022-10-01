﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object obj1, object obj2, string msg)
        {
            if (obj1.Equals(obj2))
                throw new DomainException(msg);
        }

        public static void ValidarSeDiferente(object obj1, object obj2, string msg)
        {
            if (!obj1.Equals(obj2))
                throw new DomainException(msg);
        }

        public static void ValidarTamanho(string valor, int maximo, string msg)
        {
            var length = valor.Trim().Length;
            if (length > maximo)
                throw new DomainException(msg);
        }

        public static void ValidarTamanho(string valor, int minimo, int maximo, string msg)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo)
                throw new DomainException(msg);
        }

        public static void ValidarExpressao(string pattern, string valor, string msg)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor))
                throw new DomainException(msg);
        }

        public static void ValidarSeVazio(string valor, string msg)
        {
            if (valor is null || valor.Trim().Length == 0)
                throw new DomainException(msg);
        }

        public static void ValidarSeNulo(object obj, string msg)
        {
            if (obj is null)
                throw new DomainException(msg);
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorQue(double valor, double minimo, string mensagem)
        {
            if (valor < minimo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string mensagem)
        {
            if (valor < minimo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorOuIgual(decimal valor, decimal minimo, string mensagem)
        {
            if (valor <= minimo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorQue(int valor, int minimo, string mensagem)
        {
            if (valor < minimo)
                throw new DomainException(mensagem);
        }

        public static void ValidarSeFalso(bool valor, string msg)
        {
            if (!valor)
                throw new DomainException(msg);
        }

        public static void ValidarSeVerdadeiro(bool valor, string msg)
        {
            if (valor)
                throw new DomainException(msg);
        }
    }
}
