using System.Text;

namespace Memento
{
    public class TextEditor
    {
        private int line;
        private int carriagePosition;
        private StringBuilder builder;
        
        public struct Snapshot
        {
            private int line;
            private int carriagePosition;
            private string content;

            public int Line
            {
                get { return this.line; }
            }

            public int CarriagePosition
            {
                get { return this.carriagePosition; }
            }
            
            public string Content
            {
                get { return this.content; }
            }
            
            public Snapshot(TextEditor editor)
            {
                this.line = editor.line;
                this.carriagePosition = editor.carriagePosition;
                this.content = editor.builder.ToString();
            }
        }

        public TextEditor()
        {
            this.builder = new StringBuilder();
        }

        public Snapshot GetSnapshot()
        {
            return new Snapshot(this);
        }

        public void Restore(Snapshot snapshot)
        {
            this.line = snapshot.Line;
            this.carriagePosition = snapshot.CarriagePosition;
            this.builder = new StringBuilder(snapshot.Content);
        }

        public string GetContent()
        {
            return this.builder.ToString();
        }

        public void AddLine(string text)
        {
            StringBuilder line = new StringBuilder(text);
            line.AppendLine();
            this.builder.Append(line);
        }
    }
}