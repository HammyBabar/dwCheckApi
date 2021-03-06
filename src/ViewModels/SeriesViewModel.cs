using System.Collections.Generic;

namespace dwCheckApi.ViewModels
{
    public class SeriesViewModel : BaseViewModel
    {
        public SeriesViewModel()
        {
            BookNames = new List<string>();
        }

        public string SeriesName { get; set; }
        public List<string> BookNames { get; set; }
    }
}