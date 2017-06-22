using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Data
{
    public class ComicBookRepository
    {

        private static Models.ComicBook[] _comicBooks = new Models.ComicBook[]
        {
            new Models.ComicBook()
            {
                Id=0,
                Title = "The Amazing Spider-Man",
                IssueNumber = 700,
                Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
            },
            new Models.ComicBook()
            {
                Id=1,
                Title = "The Amazing Spider-Man",
                IssueNumber = 657,
                Description = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
      
            },
            new Models.ComicBook()
            {
                Id=2,
                Title = "Bone",
                IssueNumber = 50,
                Description = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                
            }
        };

        public Models.ComicBook getComicBook(int id)
        {
            
            Models.ComicBook comicBookCliked = new Models.ComicBook();
            foreach (var comic in _comicBooks)
            {
                if (comic.Id == id)
                {
                    comicBookCliked = comic;
                    break;
                }
            }
            return comicBookCliked;
        }

        public Models.ComicBook[] getAllComicBook()
        {
            return _comicBooks;
        }
    };
    
}