using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UI.Controls.Charts.Model;
using UI.Controls.DatePickerBar;
using UI.Controls.Select;

namespace UI.Models
{
    public class DataPageModel : ModelBase
    {
        private ObservableCollection<string> TabbarData_;
        /// <summary>
        /// tabbar data
        /// </summary>
        public ObservableCollection<string> TabbarData
        {
            get { return TabbarData_; }
            set { TabbarData_ = value; OnPropertyChanged(); }
        }

        private int TabbarSelectedIndex_;
        /// <summary>
        /// tabbar selected item index
        /// </summary>
        public int TabbarSelectedIndex
        {
            get { return TabbarSelectedIndex_; }
            set
            {
                TabbarSelectedIndex_ = value;
                OnPropertyChanged();
            }
        }

        private List<ChartsDataModel> Data_;
        /// <summary>
        ///  data
        /// </summary>
        public List<ChartsDataModel> Data
        {
            get { return Data_; }
            set { Data_ = value; OnPropertyChanged(); }
        }

        private List<ChartsDataModel> MonthData_;
        /// <summary>
        ///  MonthData
        /// </summary>
        public List<ChartsDataModel> MonthData
        {
            get { return MonthData_; }
            set { MonthData_ = value; OnPropertyChanged(); }
        }

        private List<ChartsDataModel> YearData_;
        /// <summary>
        ///  YearData
        /// </summary>
        public List<ChartsDataModel> YearData
        {
            get { return YearData_; }
            set { YearData_ = value; OnPropertyChanged(); }
        }

        private List<ChartsDataModel> CustomDayData_;
        /// <summary>
        ///  CustomDayData
        /// </summary>
        public List<ChartsDataModel> CustomDayData
        {
            get { return CustomDayData_; }
            set { CustomDayData_ = value; OnPropertyChanged(); }
        }

        private DateTime DayDate_;
        /// <summary>
        ///  date
        /// </summary>
        public DateTime DayDate
        {
            get { return DayDate_; }
            set { DayDate_ = value; OnPropertyChanged(); }
        }

        private DateTime MonthDate_;
        /// <summary>
        ///  date
        /// </summary>
        public DateTime MonthDate
        {
            get { return MonthDate_; }
            set { MonthDate_ = value; OnPropertyChanged(); }
        }

        private DateTime YearDate_;
        /// <summary>
        ///  date
        /// </summary>
        public DateTime YearDate
        {
            get { return YearDate_; }
            set { YearDate_ = value; OnPropertyChanged(); }
        }

        private DateTime CustomStartDayDate_;
        /// <summary>
        ///  date
        /// </summary>
        public DateTime CustomStartDayDate
        {
            get { return CustomStartDayDate_; }
            set { CustomStartDayDate_ = value; OnPropertyChanged(); }
        }

        private SelectItemModel CustomStartHour_;
        /// <summary>
        /// CustomStartHour
        /// </summary>
        public SelectItemModel CustomStartHour
        {
            get { return CustomStartHour_; }
            set { CustomStartHour_ = value; OnPropertyChanged(); }
        }

        private DateTime CustomEndDayDate_;
        /// <summary>
        ///  date
        /// </summary>
        public DateTime CustomEndDayDate
        {
            get { return CustomEndDayDate_; }
            set { CustomEndDayDate_ = value; OnPropertyChanged(); }
        }

        private SelectItemModel CustomEndHour_;
        /// <summary>
        /// CustomEndHour
        /// </summary>
        public SelectItemModel CustomEndHour { 
            get { return CustomEndHour_; } 
            set { CustomEndHour_ = value; OnPropertyChanged(); } }


        /// <summary>
        /// 时间选项
        /// </summary>
        public List<SelectItemModel> HourOptions { get; } = CreateHourOptions();

        private static List<SelectItemModel> CreateHourOptions()
        {
            List<SelectItemModel> options = new List<SelectItemModel>();

            for (int i = 0; i <= 24; i++)
            {
                SelectItemModel item = new SelectItemModel
                {
                    Id = i,
                    Name = i + ":00"
                };

                options.Add(item);
            }

            return options;
        }

        private ContextMenu AppContextMenu_;
        public ContextMenu AppContextMenu { get { return AppContextMenu_; } set { AppContextMenu_ = value; OnPropertyChanged(); } }
    }
}
