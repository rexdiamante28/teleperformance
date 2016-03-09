@Imports System.Xml
@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"

    Try
        Dim rssDoc As New XmlDocument
        rssDoc.Load("http://www.health.com/fitness/feed")
        'rssDoc.Load("https://www.nlm.nih.gov/medlineplus/feeds/news_en.xml")



        Dim xmlnode As XmlNodeList

        xmlnode = rssDoc.GetElementsByTagName("item")

        Dim nodeCount As Integer
        nodeCount = xmlnode.Count - 1
        Dim half As Integer = (nodeCount / 2)



    @<div class="col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1 no-padd">
        <div class="col-lg-6 col-lg-offset-0 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-0  padd-10">
            @For i = 0 To half
                @<div class="col-xs-12 bgwhite top-20" style="white-space: pre-wrap; word-wrap:break-word;">
                    <text class="bold custom-fblue _17 pull-left text-center">@Regex.Replace(xmlnode(i).ChildNodes.Item(0).InnerText.Trim(), "[ ](?=[ ])|[^-_,A-Za-z0-9 ]+", "")</text><br /><br />
                    @Regex.Replace(xmlnode(i).ChildNodes.Item(6).InnerText.Trim(), "[ ](?=[ ])|[^-_,A-Za-z0-9 ]+", "")
                    <img class="col-xs-12" src="@xmlnode(i).ChildNodes.Item(8).ChildNodes.Item(0).Attributes(0).InnerText" />
                    <a target="_blank" class="pull-right _15 bold" href="@xmlnode(i).ChildNodes.Item(1).InnerText.Trim()">See more...</a>
                    <br /><text class="pull-right text-muted _12">@xmlnode(i).ChildNodes.Item(2).InnerText.Trim()</text>
                </div>
                Next
        </div>

        <div class="col-md-6 col-lg-6 col-lg-offset-0 col-sm-8 col-sm-offset-2 col-md-offset-0   padd-10">
            @For i = half To nodeCount
                @<div class="col-xs-12 bgwhite top-20" style="white-space: pre-wrap; word-wrap:break-word;">
                    <text class="bold custom-fblue _17 pull-left text-center">@Regex.Replace(xmlnode(i).ChildNodes.Item(0).InnerText.Trim(), "[ ](?=[ ])|[^-_,A-Za-z0-9 ]+", "")</text><br /><br />
                    @Regex.Replace(xmlnode(i).ChildNodes.Item(6).InnerText.Trim(), "[ ](?=[ ])|[^-_,A-Za-z0-9 ]+", "")
                    <img class="col-xs-12" src="@xmlnode(i).ChildNodes.Item(8).ChildNodes.Item(0).Attributes(0).InnerText" />
                    <a target="_blank" class="pull-right _15 bold" href="@xmlnode(i).ChildNodes.Item(1).InnerText.Trim()">See more...</a>
                    <br /><text class="pull-right text-muted _12">@xmlnode(i).ChildNodes.Item(2).InnerText.Trim()</text>
                </div>
                Next
        </div>

    </div>

Catch ex As Exception
    @<div class="col-xs-12 col-sm-4 col-sm-offset-4  padd-20 top-100">
        <h1 class="text-muted">Problem loading the RSS feed.</h1>
        <hr>
        <p class="text-muted">http://www.health.com/fitness/feed is down at the moment. News feeds will be availble once they fixed the problem at their end.</p>
    </div>
End Try

End Code





<script>
    document.getElementById('topbar2').setAttribute("class","bggray5");
</script>
