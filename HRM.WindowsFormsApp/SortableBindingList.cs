
using System.Collections.Generic;
using System.ComponentModel;

namespace TestTask.WindowsFormsApp
{
    internal class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;

        public PropertyDescriptor SortProperty { get; private set; }
        public ListSortDirection SortDirection { get; private set; }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var itemsList = (List<T>)Items;
            itemsList.Sort((x, y) =>
            {
                var xValue = prop.GetValue(x);
                var yValue = prop.GetValue(y);
                return direction == ListSortDirection.Ascending
                    ? Comparer<object>.Default.Compare(xValue, yValue)
                    : Comparer<object>.Default.Compare(yValue, xValue);
            });
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
        }
    }
}
