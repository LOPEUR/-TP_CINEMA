// See https://aka.ms/new-console-template for more information
using DM_PATHE;
film film1 = film.getInstance( "Science-Fiction", "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty(interprété par Rutger Hauer","Blade Runner",1982,acteur1);
film film2 = film.getInstance("Animation", "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story", 1992,acteur2);
Console.WriteLine(film1.ToString());
acteur acteur1 = acteur.getinstance("Ford","Harrison" ,1 , 1942);
acteur acteur2 = acteur.getinstance("Tom","Hanks" ,2 , 1956);

Console.WriteLine(acteur1.ToString());
