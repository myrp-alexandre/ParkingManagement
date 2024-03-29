﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMangement.Utils
{
    class Constant
    {
        // common
        public static string sMessageCommonError = "Có lỗi xảy ra";
        public static string sMessageDuplicateDataError = "Dữ liệu đã tồn tại";
        public static string FUNCTION_ID_NHAN_VIEN = "Nh";

        // user
        public static string sMessageUserIdNullError = "Mã thẻ không được rỗng";
        public static string sMessageUserNameNullError = "Họ và tên không được rỗng";
        public static string sMessageAccountNullError = "Tài khoản không được rỗng";
        public static string sMessagePasswordNullError = "Mật khẩu không được rỗng";

        // part
        public static string sMessagePartIdNullError = "Mã loại xe không được rỗng";
        public static string sMessagePartNameNullError = "Tên loại xe không được rỗng";
        public static string sMessagePartAmountNullError = "Tiền thu tháng không được rỗng";
        public static string sMessagePartLimitNullError = "Hạn mức không được rỗng";

        // card
        public static string sMessageCardIdNullError = "Mã thẻ chíp không được để trống";
        public static string sLabelCardUsing = "Dùng";
        public static string sLabelCardNotUsing = "Không dùng";

        // Ticktet month
        // user
        public static string sMessageTicketMonthIdNullError = "Mã thẻ không được rỗng";
        public static string sMessageTicketMonthIdDuplicateError = "Mã thẻ không được trùng";
        public static string sMessageTicketMonthDigitNullError = "Biển số không được rỗng";
    }
}
