using System;
using System.Collections.Generic;
using ICT13580101EndB.Models;
using Xamarin.Forms;

namespace ICT13580101EndB
{
    public partial class ProductNewPage : ContentPage
    {
        public ProductNewPage()
        {
            InitializeComponent();

            typePicker.Items.Add("รถมือหนึ่ง");
            typePicker.Items.Add("รถมือสอง");

            yehorPicker.Items.Add("toyota");
            yehorPicker.Items.Add("honda");
            yehorPicker.Items.Add("mazda");

            colorPicker.Items.Add("สีดำ");
            colorPicker.Items.Add("สีขาว");
            colorPicker.Items.Add("สีแดง");

            provicePicker.Items.Add("กรุงเทพมหานคร");
            provicePicker.Items.Add("เพชรบุรี");
            provicePicker.Items.Add("เชียงใหม่");

            yearEntry.ValueChanged += YearEntry_ValueChanged;

            milelEntry.ValueChanged += MilelEntry_ValueChanged;

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isok = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isok)
            {
                var product = new Product();
                product.Type = typePicker.SelectedItem.ToString();
                product.Yehor = yehorPicker.SelectedItem.ToString();
                product.Genalation = genalationEntry.Text;
                product.Year = int.Parse(yearLabel.Text);
                product.Mile = int.Parse(mileLabel.Text);
                product.Color = colorPicker.SelectedItem.ToString();
                product.Deler = delerSwitch.IsToggled;
                product.Detail = detailEditor.Text;
                product.Price = decimal.Parse(priceEntry.Text);
                product.Provice = provicePicker.SelectedItem.ToString();
                product.Phone = phoneEntry.Text;
                var id = App.DbHelper.AddProduct(product);
                await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");
            }
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void YearEntry_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            yearLabel.Text = value.ToString();
        }

        void MilelEntry_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            mileLabel.Text = value.ToString();
        }
    }
}
