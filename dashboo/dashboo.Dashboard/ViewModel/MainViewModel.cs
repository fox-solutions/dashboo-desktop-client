namespace dashboo.Dashboard.ViewModel
{
    class MainViewModel
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public MainViewModel()
        {
            Title = "dashboo";
        }
    }
}
