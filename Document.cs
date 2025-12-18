using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Document
    {
        protected string _author {  get; set; }

        protected Document(string author)
        {
            _author = author;
        }
        public abstract void Render();
    }
    class TextDocument: Document
    {
        private string _content { get; set; }
        public TextDocument(string author, string content): base(author)
        {
            _content = content;
        }
        public override void Render()
        {
            Console.WriteLine(_content);
        }
    }
    class ImageDocument : Document
    {
        private string _resolution { get; set; }
        public ImageDocument(string author, string resolution) : base(author)
        {
            _resolution = resolution;
        }
        public override void Render()
        {
            Console.WriteLine($"загружается изображение с расширением {_resolution}");
        }
    }
}
