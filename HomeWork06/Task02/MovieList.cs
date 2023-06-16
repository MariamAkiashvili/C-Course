using MyMovies;
using System;
using System.Collections.Generic;

public class MoviesList
{
   // private Movie[] _movies; 
    private int _count;

    private List <Movie> _movies;

    public MoviesList(List <Movie> movies)
    {
        _movies = movies;
    }

    public int Count
    {
        get { return _count; }
        set { _count = _movies.Count; }
    }


    public Movie this[int i]
    {
        get { return _movies[i]; }
        set { _movies[i] = value; }
    }
        

    public void AddElement (Movie movie)
    {
        //Array.Resize (ref _movies, _count+1);
        _movies[_movies.Count-1] = movie;

    }

    public void AddList(Movie[] movies)
    {
        for (int i = 0; i < movies.Length; i++)
        {
            AddElement(movies[i]);
        }
    }

    public bool InsertElement(Movie movie, int index)
    {
        if (index >= _movies.Count)
        {
            return false;
        }
        else
        {
            _movies[index] = movie;
            return true;
        }
    }
    
    public bool InsertList(Movie[] movies, int index)
    {
        if(index + movies.Length > _count - 1)
        {
            return false;
        }
        else
        {
            InsertList(movies, index);
            return true;
        }
    }

    public object GetElement (int index)
    {
        if( index >= _movies.Count)
        {
            return false;
        }
        else
        {
            return _movies[index];
        }
        
    } 

    public object GetList (int index, int num)
    {
        if (index < 0 || index >= _movies.Count || num <= 0 || index + num > _movies.Count)
        {
            return false;
        }
        else
        {
            List <Movie> list = new List<Movie>();
            for (int i = index; i < num; i++)
            {
                list.Add(_movies[i]);
            }
            return list;
        }
        
    }

    public void RemoveElement(Movie movie)
    {
        int index = _movies.IndexOf(movie);
        if (index >= 0)
        {
            _movies.RemoveAt(index);
        }
    }

    public void RemoveList(List <Movie> movies)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            RemoveElement(movies[i]);
        }
    }

    public void Clear()
    {
        RemoveList(_movies);
    }

    public List <Movie> Find(string title = "", string description = "", int releaseYear = 0, string director = "")
    {
        List <Movie> movies = new List <Movie>();
        for (int i = 0; i < _movies.Count; i++)
        {
            
            if ((title == "" || title == _movies[i].Title ) 
                    && (description == "" || description == _movies[i].Description)
                    && (releaseYear == 0 || releaseYear == _movies[i].ReleaseYear)
                    && (director == "" || director == _movies[i].Director))
            {
                
                movies.Add(_movies[i]);

            }

        }
        return movies;


    }
}