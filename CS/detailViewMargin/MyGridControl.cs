using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.Handler;
using System.Drawing;
using System.ComponentModel;

namespace detailViewMargin
{
    class MyGridControl : GridControl
    {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(DevExpress.XtraGrid.Registrator.InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }
    }

    public class MyGridView : GridView
    {
        public MyGridView() : base() { }

        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override string ViewName { get { return "MyGridView"; } }
    }

    public class MyGridInfoRegistrator : GridInfoRegistrator
    {
        public MyGridInfoRegistrator() : base() { }

        public override string ViewName { get { return "MyGridView"; } }

        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }

        public override DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo CreateViewInfo(BaseView view) { return new MyGridViewInfo((MyGridView)view); }

        public override DevExpress.XtraGrid.Views.Base.Handler.BaseViewHandler CreateHandler(BaseView view) { return new GridHandler((MyGridView)view); }
    }

    public class MyGridViewInfo : GridViewInfo
    {
        private int childViewMargin;

        public MyGridViewInfo(GridView gridView) : base(gridView) { childViewMargin = gridView.LevelName != string.Empty ? 20 : 0; }

        protected override System.Drawing.Rectangle CalcBorderRect(System.Drawing.Rectangle bounds)
        {
            Rectangle result = base.CalcBorderRect(bounds);
            result.Width -= childViewMargin;
            return result;
        }
    }
}
