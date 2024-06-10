using System;

namespace ExceptionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Appel de la fonction ThrowError qui lève une CustomException
                ThrowError();
            }
            catch (CustomException ex)
            {
                // Affichage des informations de l'exception dans la console
                Console.WriteLine($"Exception levée à : {ex.ExceptionTime}");
                Console.WriteLine($"Message de l'exception : {ex.Message}");
            }
        }

        // Fonction qui lève une CustomException
        static void ThrowError()
        {
            throw new CustomException("Survenance d'une erreur personnalisée.");
        }
    }
}
