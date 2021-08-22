using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_MVVM
{
    public class MainViewModel : MainViewModelBase
    {
        private Calculator calculator = null;
        private int result_ = 0;
        private int value1_ = 0;
        private int value2_ = 0;
        private bool isAddChecked_ = false;
        private bool isSubChecked_ = false;
        private bool isMulChecked_ = false;
        private bool isDivChecked_ = false;
        private bool isAnyRadioButtonChecked_ = false;
        private bool IsAnyRadioButtonChecked
        {
            get { return isAnyRadioButtonChecked_; }
            set
            {
                isAnyRadioButtonChecked_ = value;
                OnPropertyChanged("IsAnyRadioButtonChecked");
            }
        }
        private int value1
        {
            get { return value1_; }
            set
            {
                value1_ = value;
                OnPropertyChanged("value1");
            }
        }
        private int value2
        {
            get { return value2_; }
            set
            {
                value2_ = value;
                OnPropertyChanged("value2");
            }
        }
        private int Result
        {
            get { return result_; }
            set
            {
                if(value != result_)
                {
                    result_ = value;
                    OnPropertyChanged("Result");
                }
            }
        }
        private bool IsAddChecked
        {
            get { return isAddChecked_; }
            set
            {
                if (value != isAddChecked_)
                {
                    isAddChecked_ = value;
                    OnPropertyChanged("IsAddChecked");
                }
            }
        }
        private bool IsSubChecked
        {
            get { return isSubChecked_; }
            set
            {
                if (value != isSubChecked_)
                {
                    isSubChecked_ = value;
                    OnPropertyChanged("IsSubChecked");
                }
            }
        }
        private bool IsMulChecked
        {
            get { return isMulChecked_; }
            set
            {
                if (value != isMulChecked_)
                {
                    isMulChecked_ = value;
                    OnPropertyChanged("IsMulChecked");
                }
            }
        }
        private bool IsDivChecked
        {
            get { return isDivChecked_; }
            set
            {
                if (value != isDivChecked_)
                {
                    isDivChecked_ = value;
                    OnPropertyChanged("IsDivChecked");
                }
            }
        }
    }
}
