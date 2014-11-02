using Microsoft.WindowsAzure.Mobile.Service;

namespace TBXUG1Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}