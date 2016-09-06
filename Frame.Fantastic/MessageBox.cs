using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class MessageBox : FantasticHelperBase
    {
        private string _id;
        private string _name;
        private string _cssclass;
        private string _title;
        private string _content;
        private string _messagetype="Info";
        public MessageBox ID(string id)
        {
            this._id = id;
            return this;
        }

        public MessageBox Name(string name)
        {
            this._name = name;
            return this;
        }
        public MessageBox Cssclass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }
        public MessageBox Title(string title)
        {
            this._title = title;
            return this;
        }
        public MessageBox Content(string content)
        {
            this._content = content;
            return this;
        }
        public MessageBox MessageType(MessageType type)
        {
            this._messagetype = type.ToString();
            return this;
        }
        public string show()
        {
            return "fan_msg('" + this._id + "','" + this._title + "','" + this._content + "','" + this._messagetype + "');";
        }

        public override string Render()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<script type=\"text/javascript\">");
            builder.Append("jQuery(function(){fan_msg('" + this._id + "','" + this._title + "','" + this._content + "','"+this._messagetype+"');});");
            builder.Append("</script>");
            return builder.ToString();
        }

        public static string Info(string content)
        {
            return new MessageBox().MessageType(Frame.Fantastic.MessageType.Info).Content(content).show();
        }
        public static string Success(string content)
        {
            return new MessageBox().MessageType(Frame.Fantastic.MessageType.Success).Content(content).show();
        }
        public static string Warn(string content)
        {
            return new MessageBox().MessageType(Frame.Fantastic.MessageType.Warn).Content(content).show();
        }
        public static string Error(string content)
        {
            return new MessageBox().MessageType(Frame.Fantastic.MessageType.Error).Content(content).show();
        }
    }

    public enum MessageType
    {
        Info,
        Success,
        Warn,
        Error
    }

}
