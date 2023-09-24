﻿using System;
using BookMan.ConsoleApp.Framework;
namespace BookMan.ConsoleApp.Views // namespace  cách đặt 
{
    using Models; // using bên trong namespace 
    /// <summary>
    /// Class để hiển thị một cuốn sách, chỉ sử dụng trng dự án (internal )
    /// </summary>
    internal class BookSingleView
    {
        protected Book Model; // biến này chỉ để lưu trữ thông tin cuốn sách đang cần hiển thị 
        /// <summary>
        /// Đây là hàm tạo, sẻ được gọi đầu tiên khi tạo object 
        /// </summary>
        /// <param name="model">Cuốn sách cụ thể sẻ được hiển thị </param>
        public BookSingleView(Book model)
        {
          Model = model;// chuyển dữ liệu từ tham số sang biến thành viên để sử dụng trong toàn class 

        }
        /// <summary>
        /// Thực hiện in thông tin ra màn hình console 
        /// </summary>
        public void Render()
        {
            if (Model == null)  // kiiểm tra xem object có dữ liệu không 
            {
               ViewHelp.WriteLine("NO BOOK FOUND. SORRY!", ConsoleColor.Red);
                return; // Kết thức thực hiện phương thức (bỏ qua phần còn lại )
            }
           ViewHelp.WriteLine("BOOK DETAIL INFORMATION", ConsoleColor.Green);
            /*
             các dòng dưới đây viết ra thông tin cụ thể theo từng dòng 
            sử dụng cách tạo xâu kiểu "interpolation "
            và dùng dấu cách để căn chỉnh tạo thẩm mỹ 
             */
            Console.WriteLine($"Authors:            {Model.Authors}");
            Console.WriteLine($"Title:                  {Model.Title}");
            Console.WriteLine($"Publisher:          {Model.Publisher}");
            Console.WriteLine($"Year:                   {Model.Year}");
            Console.WriteLine($"Edition:               {Model.Edittion}");
            Console.WriteLine($"Isbn:                    {Model.Isbn}");
            Console.WriteLine($"Tags:                   {Model.Tags}");
            Console.WriteLine($"Description:        {Model.Description}");
            Console.WriteLine($"Rating:                 {Model.Rating}");
            Console.WriteLine($"Reading:                {Model.Reading}");
            Console.WriteLine($"File:                       {Model.File}");
            Console.WriteLine($"File Name:              {Model.FileName}");
        }
      public void RenderToFile(string path)
        {
            ViewHelp.WriteLine($"Saving data to file '{path}' ");
            var json = Newtonsoft.Json.JsonConvert.SerializeObject( Model );
            System.IO.File.WriteAllText( path, json );
            ViewHelp.WriteLine("Done");
        }
    }
}
