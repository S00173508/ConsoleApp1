<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BlackBoxTesting.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <h3>Insurance Calculator</h3>
    <script>
        function CalcPremium( age, gender)
        {
            var premium;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else
                    if (age >= 31)
                    premium = 3.50;
                else
                    premium = 0.0;
            }

            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else
                    if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            }
            else
                premium = 0.0;

            if (age >= 50)
                premium = premium * 0.5;

            result = premium;

        }
    
    </script>
   <table>
            <tr>
                <th> Gender </th>
                <td> <input type="text" id="gender" name="gender" class="form-control"/> </td>
            </tr>
            <tr>
                <th> Age </th>
                <td> <input type="text" id="age" name="age" class="form-control" /> </td>
            </tr>
            <tr>
                <th><input type="submit" name="Cal" value="Calculate" class="btn btn-primary" onclick="CalcPremium();" /></th>
           
            </tr>
            <tr>
                <th>Result</th>
                <td><input type="text" class="form-control" runat="server" id="result"  /> </td>
            </tr>
        </table>
 

</asp:Content>
