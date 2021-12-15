using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using DollarApp.iOS.CustomRenderers;

//string switch old textcell on new
[assembly: ExportRenderer(typeof(TextCell), typeof(CustomTextCellRender))]
namespace DollarApp.iOS.CustomRenderers
{
    public class CustomTextCellRender : TextCellRenderer
    {
        //get cell
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            //describe different types view right part cell.
            var cell = base.GetCell(item, reusableCell, tv);

            switch (item.StyleId)
            {
                case "none":
                    cell.Accessory = UITableViewCellAccessory.None;
                    break;
                case "checkmark":
                    cell.Accessory = UITableViewCellAccessory.Checkmark;
                    break;
                case "detail-botton":
                    cell.Accessory = UITableViewCellAccessory.DetailButton;
                    break;
                case "detail-disclosure-button":
                    cell.Accessory = UITableViewCellAccessory.DetailDisclosureButton;
                    break;
                case "disclosure":
                default:
                    cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
                    break;
            }

            return cell;
        }


    }
}