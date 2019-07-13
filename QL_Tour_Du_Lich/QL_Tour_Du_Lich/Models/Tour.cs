﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_Tour_Du_Lich.Models
{
    public class Tour
    {
        [HiddenInput(DisplayValue =false)]
        [Key]
        public int Tour_Id { get; set; }
        [Required(ErrorMessage ="Vui lòng không để trống !")]
        [Display(Name ="Tên tour")]
        public string Ten_Tour { get; set; }
        [Display(Name ="Hình ảnh")]
        public string Hinh_Anh { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống !")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Thời gian đi")]
        public DateTime Thoi_Gian_Di { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống !")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Thời gian về")]
        public DateTime Thoi_Gian_Ve { get; set; }
        [HiddenInput(DisplayValue =false)]
        public int Ma_Loai_Tour { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống !")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Lịch trình")]
        public string Lich_Trinh { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống !")]
        [Display(Name = "Trạng thái")]
        public string Trang_Thai { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống !")]
        [Display(Name = "Tổng số người tham gia")]
        public int So_Luong_Tham_Gia { get; set; }
        [Display(Name = "Tổng số người đã tham gia")]
        public int So_Luong_Da_Tham_Gia { get; set; }
        public virtual Loai_Tour Loai_Tour { get; set; }
    }
}