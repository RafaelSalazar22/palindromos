using Microsoft.AspNetCore.Mvc;
using palindromos.Entities;
using System;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;
/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2, Ejercicio 2: Palindromos
    Nombre del alumno: Rafael Salazar Perera
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace palindromos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
         [HttpPost]

        public string Post (Palabra dto)
        {
            string Frase = dto.frase.Replace(" ", "").ToLower();
            string Cara;
            string inver = "";
            string mensajes;

            int i = Frase.Length;
            MatchCollection wordColl = Regex.Matches(dto.frase, @"[\W]+");

            for(int x = (i - 1); x >= 0; x--)
            {
                Cara = Frase.Substring(x, 1);
                inver = inver + Cara;
            }

            if (Frase == inver)
            {
                mensajes = "es palindromio";
            }
            else
            {
                mensajes = "no es palindromo";
            }
            return (mensajes+ "cuenta con numero de palabras:"+(wordColl.Count+1));
          
        }

    }
}