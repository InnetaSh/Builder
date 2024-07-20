//Вы работаете над системой генерации отчетов для крупной компании. 
//Каждый отчет может содержать заголовок, введение, тело, заключение и список приложений.
// Компания хочет иметь возможность создавать разные типы отчетов, такие как HTML, PDF и текстовые отчеты. 
//Вам необходимо использовать паттерн "Строитель" для создания этих отчетов.

//Требования
//Создайте интерфейс IReportBuilder, который будет определять методы для создания различных частей отчета:

//SetTitle(string title)
//SetIntroduction(string introduction)
//SetBody(string body)
//SetConclusion(string conclusion)
//SetAppendix(string appendix)
//GetReport(): возвращает объект типа Report.
//Реализуйте конкретные строители для каждого типа отчета:

//HtmlReportBuilder
//PdfReportBuilder
//TextReportBuilder
//Создайте класс Report, который будет представлять конечный продукт отчета. Он должен содержать свойства для заголовка, введения, тела, заключения и списка приложений.

//Реализуйте класс ReportDirector, который будет использовать IReportBuilder для создания отчетов. 
//Этот класс должен иметь метод Construct, который принимает объект IReportBuilder и последовательно вызывает методы для создания частей отчета.

//В классе Program создайте примеры использования ReportDirector и различных строителей для создания отчетов.
//Выведите результаты на консоль или сохраните их в файлы.


public interface IReportBuilder
{
    public void SetTitle(string title);
    public void SetIntroduction(string introduction);
    public void SetBody(string body);
    public void SetConclusion(string conclusion);
    public void SetAppendix(string appendix);
    Report GetReport();
}

public class Report
{
    public string Title { get; set; }
    public string Introduction { get; set; }
    public string Body { get; set; }
    public string Conclusion { get; set; }

    public string Appendix;

    public override string ToString()
    {

        return($"Title: {Title}\nIntroduction: {Introduction}\nBody: {Body}\nConclusion: {Conclusion}\nAppendix: {Appendix}");
        
    }

}

class HtmlReportBuilder : IReportBuilder
{
    private Report report;

    public HtmlReportBuilder()
    {
        this.report = new Report();
    }


    public void SetTitle(string title)
    {
        report.Title = title;
    }

    public void SetIntroduction(string introduction)
    {
        report.Introduction = introduction;
    }

    public void SetBody(string body)
    {
        report.Body = body;
    }

    public void SetConclusion(string conclusion)
    {
        report.Conclusion = conclusion;
    }

    public void SetAppendix(string appendix)
    {
        report.Appendix = appendix;
    }

    public Report GetReport()
    {
        return report;
    }
}

public class PdfReportBuilder : IReportBuilder
{
    private Report report;

    public PdfReportBuilder()
    {
        this.report = new Report();
    }

    public void SetTitle(string title)
    {
        report.Title = title;
    }

    public void SetIntroduction(string introduction)
    {
        report.Introduction = introduction;
    }

    public void SetBody(string body)
    {
        report.Body = body;
    }

    public void SetConclusion(string conclusion)
    {
        report.Conclusion = conclusion;
    }

    public void SetAppendix(string appendix)
    {
        report.Appendix = appendix;
    }

    public Report GetReport()
    {
        return report;
    }
}


public class TextReportBuilder : IReportBuilder
{
    private Report report;

    public TextReportBuilder()
    {
        this.report = new Report();
    }

    public void SetTitle(string title)
    {
        report.Title = title;
    }

    public void SetIntroduction(string introduction)
    {
        report.Introduction = introduction;
    }

    public void SetBody(string body)
    {
        report.Body = body;
    }

    public void SetConclusion(string conclusion)
    {
        report.Conclusion = conclusion;
    }

    public void SetAppendix(string appendix)
    {
        report.Appendix = appendix;
    }

    public Report GetReport()
    {
        return report;
    }
}


//Реализуйте класс ReportDirector, который будет использовать IReportBuilder для создания отчетов. 
//Этот класс должен иметь метод Construct, который принимает объект IReportBuilder и последовательно вызывает методы для создания частей отчета.
public class ReportDirector
{
    public void Construct(IReportBuilder builder)
    {
        builder.SetTitle("Report");
        builder.SetIntroduction("Introduction of tre Report.");
        builder.SetBody("Body of tre Report.");
        builder.SetConclusion("Conclusion of tre Report.");
        builder.SetAppendix("Appendix .");
    }
}

//В классе Program создайте примеры использования ReportDirector и различных строителей для создания отчетов.
//Выведите результаты на консоль или сохраните их в файлы.

class Program
{
    static void Main(string[] args)
    {
        ReportDirector director = new ReportDirector();

        IReportBuilder reportBuilder = new HtmlReportBuilder();

        director.Construct(reportBuilder);
        Report report = reportBuilder.GetReport();
        Console.WriteLine(report);
    }
}

