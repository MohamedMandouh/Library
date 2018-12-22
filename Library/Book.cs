using System;

public class Book
{
    private string name;
    private string genre;
    private int index;


	public Book(string name,string genre,int index)
	{
        this.name = name;
        this.genre = genre;
        this.index = index;
	}

    public string getName(){ return name; }
    public string getGenre() { return genre; }
    public int getIndex() { return index; }

}
