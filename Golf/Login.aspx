<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Golf.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <div id="testimonails">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-section">
                                <img src="images/under-heading.png" alt="" >
                            </div>
                        </div>
                    </div>
                   
                                <li>
								<form action="/action_page.php">
									<div class="imgcontainer">
									<img src="" alt="Please Fill In The Blank" class="avatar">
									</div>

									<div class="container">
									<label><b>Username</b></label>
									<input type="text" placeholder="Enter Username" name="uname" required>

									<label><b>Password</b></label>
									<input type="password" placeholder="Enter Password" name="psw" required>

									<button type="submit">Login</button>
									<input type="checkbox" checked="checked"> Remember me
									</div>

									<div class="container" style="background-color:#f1f1f1">
									<button type="button" class="cancelbtn">Cancel</button>
									<span class="psw">Forgot <a href="#">password?</a></span>
									</div>
								</form>
                                   
                                </li>
                              </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
