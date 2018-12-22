using System;

public class Book
{
    private string name;
    private string genre;
    private int index;

    public Book() { }

    public Book(string name,string genre,int index)
	{
        this.name = name;
        this.genre = genre;
        this.index = index;
	}

    

    public string getName(){ return name; }
    public string getGenre() { return genre; }
    public int getIndex() { return index; }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setGenre(string genre)
    {
        this.genre = genre;
    }

    public void setIndex(string index)
    {
        this.index = index;
    }
}
