using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.src.Service
{
    class BoardService
    {
        Model.Board board;
        public BoardService()
        {
            this.board = new Model.Board();
        }
        public BoardService(Model.Board board)
        {
            this.board = board;
        }
        public void Save(int number, string title, string content, string writer)
        {
            board.Number = number;
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            Console.WriteLine("the post is saved.");
        }
        public void Update(string title, string content, string writer)
        {
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.UpdateDate = DateTime.Now;

            Console.WriteLine("the post is updated");
        }
        public void Delete()
        {
            board = null;

            Console.WriteLine("The post is deleted");
        }
        public void Read()
        {
            if(board != null)
            {
                Console.WriteLine("No.{0} post", board.Number);
                Console.WriteLine("Title : {0}", board.Title);
                Console.WriteLine("CreateDate : {0}", board.CreateDate);
                Console.WriteLine("UpdateDate : {0}", board.UpdateDate);
                Console.WriteLine("Writer : {0}", board.Writer);
                Console.WriteLine("Contents : {0}", board.Contents);
            }
            else
            {
                Console.WriteLine("There is not any post");
            }
        }
    }
}
