using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core
{
    public enum Menus
    {
        상품목록 = 1,
        빠른입고 = 2,
        빠른출고 = 3,
        입출고전체 = 4,
        재고현황 = 5,
        사용자 = 6,
        바코드목록 = 7,
    }

    public enum UserTypes
    {
        관리자 = 0,
        사용자 = 1,
        퇴자사 = 2
    }

    public enum FrmExcelTypes
    {
        사용자 = 0,
        상품 = 1
    }

    public enum TransationTypes
    {
        입고,
        출고
    }
}
