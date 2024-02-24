public class Company {
    public string name { get; set; } = "";
    public int workers { get; set; } = 0;

    public static string GetCompanyWithMaxWorkers(params Company[] companies) {
        if (companies == null || companies.Length == 0)
            throw new ArgumentException("Необхідно вказати принаймні один об’єкт компанії");

        int maxWorkers = companies[0].workers;
        string companyName = companies[0].name;

        for (int i = 1; i < companies.Length; i++) {
            if (companies[i].workers > maxWorkers) {
                maxWorkers = companies[i].workers;
                companyName = companies[i].name;
            }
        }

        return companyName;
    }
}