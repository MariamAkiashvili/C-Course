
using MyMovies;
using System;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");

Movie movie1 = new Movie();
movie1.Title = "Pulp Fiction";
movie1.ReleaseYear = 1994;
movie1.Director = "Quentin Tarantino";

Movie movie2 = new Movie();
movie2.Title = "Fight Club";
movie2.ReleaseYear = 1999;
movie2.Director = "David Fincher";

List<Movie> movies = new List<Movie>();
movies.Add(movie1);
movies.Add(movie2);

MoviesList myList = new MoviesList(movies);

Console.WriteLine(((Movie)myList.GetElement(1)).Title);

List<Movie> getList = new List<Movie>();
    
getList.AddRange((List <Movie>)myList.GetList(0, 2));


for (int i = 0; i < getList.Count; i++)
{
    Console.WriteLine(getList[i].Title);
}

myList.RemoveElement(movie1);

for(int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i].Title);
}


List<Movie> selectedMovies = new List<Movie>(myList.Find(releaseYear: 1999));


for (int i = 0;i < selectedMovies.Count; i++)
{
    Console.WriteLine(selectedMovies[i].Title);
}


myList.Clear();
Console.WriteLine(myList.Count);



Console.ReadLine();
