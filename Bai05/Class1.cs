namespace DeliveryOrderDashboard
{
    public class DeliveryItem
    {
        public string TenHang { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal TrongLuong { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien
        {
            get
            {
                return SoLuong * DonGia;
            }
        }
    }
}