<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="deneme.AdminPanel" %>


<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Free HTML5 Template by FREEHTML5.CO" />
    <meta name="keywords" content="free html5, free template, free bootstrap, html5, css3, mobile first, responsive" />
    <meta name="author" content="FREEHTML5.CO" />

    <!-- 
	//////////////////////////////////////////////////////

	FREE HTML5 TEMPLATE 
	DESIGNED & DEVELOPED by FREEHTML5.CO
		
	Website: 		http://freehtml5.co/
	Email: 			info@freehtml5.co
	Twitter: 		http://twitter.com/fh5co
	Facebook: 		https://www.facebook.com/fh5co

	//////////////////////////////////////////////////////
	 -->

    <!-- Facebook and Twitter integration -->
    <meta property="og:title" content="" />
    <meta property="og:image" content="" />
    <meta property="og:url" content="" />
    <meta property="og:site_name" content="" />
    <meta property="og:description" content="" />
    <meta name="twitter:title" content="" />
    <meta name="twitter:image" content="" />
    <meta name="twitter:url" content="" />
    <meta name="twitter:card" content="" />

    <!-- Place favicon.ico and apple-touch-icon.png in the root directory -->
    <link rel="shortcut icon" href="favicon.ico">

    <!-- Google Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Playfair+Display:400,700,400italic|Roboto:400,300,700' rel='stylesheet' type='text/css'>
    <!-- Animate -->
    <link rel="stylesheet" href="css/animate.css">
    <!-- Icomoon -->
    <link rel="stylesheet" href="css/icomoon.css">
    <!-- Bootstrap  -->
    <link rel="stylesheet" href="css/bootstrap.css">

    <link rel="stylesheet" href="css/style.css">
    <link href="css/dropdownloginstyle.css" rel="stylesheet" />
    <script src="js/dropdownloginindex.js"></script>
    <!-- Modernizr JS -->
    <script src="js/modernizr-2.6.2.min.js"></script>
    <script src="js/jquery.easing.1.3.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.waypoints.min.js"></script>
    <script src="js/modernizr-2.6.2.min.js"></script>
    <!-- FOR IE9 below -->
    <!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

</head>
<body>
    <div id="fh5co-offcanvas">
        <a href="#" class="fh5co-close-offcanvas js-fh5co-close-offcanvas"><span><i class="icon-cross3"></i><span>Close</span></span></a>
        <div class="fh5co-bio">
            <form class="form-horizontal">
                <fieldset>

                    <!-- Form Name -->
                    <legend>Ne Aramıştınız</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="location">Anahtar kelime</label>
                        <div class="col-md-4">
                            <input id="location" name="location" type="text" placeholder="Ne Aramıştın?" class="form-control input-md" style="width: 200px;">
                            <span class="help-block">Örn:At..</span>
                        </div>
                    </div>

                    <!-- Select Basic -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="radius">Ürün cinsi</label>
                        <div class="col-md-4">
                            <select id="radius" name="radius" class="form-control" style="width: 200px;">
                                <option value="1">Option one</option>
                                <option value="2">Option two</option>
                            </select>
                        </div>
                    </div>

                    <!-- Select Basic -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="property_type">Fiyat aralığı</label>
                        <div class="col-md-4">
                            <select id="property_type" name="property_type" class="form-control" style="width: 200px;">
                                <option value="1">Option one</option>
                                <option value="2">Option two</option>
                            </select>
                        </div>
                    </div>

                    <!-- Select Basic -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="price_min">Renk</label>
                        <div class="col-md-2">
                            <select id="price_min" name="price_min" class="form-control" style="width: 200px;">
                                <option value="1">Option one</option>
                                <option value="2">Option two</option>
                            </select>
                        </div>
                    </div>

                    <!-- Select Basic -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="selectbasic">Model</label>
                        <div class="col-md-2">
                            <select id="selectbasic" name="selectbasic" class="form-control" style="width: 200px;">
                                <option value="1">Option one</option>
                                <option value="2">Option two</option>
                            </select>
                        </div>
                    </div>

                    <!-- Button -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="submit"></label>
                        <div class="col-md-4">
                            <button id="submit" name="submit" class="btn btn-primary">Ara</button>
                        </div>
                    </div>

                </fieldset>
            </form>
        </div>

        <div class="fh5co-menu">
            <div class="fh5co-box">
                <h3 class="heading">Categories</h3>
                <ul>
                    <li><a href="#">Hediyelik</a></li>
                    <li><a href="#">Ev tekstil</a></li>
                    <li><a href="#">Tarla</a></li>
                    <li><a href="#">Fabrika & İşyeri</a></li>
                    <li><a href="#">Mülk</a></li>
                </ul>
            </div>
            <div class="fh5co-box">
                <h3 class="heading">Categories</h3>
                <ul>
                    <li><a href="#">Biz kimiz?</a></li>
                    <li><a href="#">Vizyon & Misyon</a></li>
                    <li><a href="#">At</a></li>
                    <li><a href="#">Burlara da bişeyler gelir</a></li>
                    <li><a href="#">İletişim</a></li>
                </ul>
            </div>

        </div>
    </div>
    <!-- END #fh5co-offcanvas -->
    <header id="fh5co-header">
        <form action="/" method="get" runat="server">
            <div class="container-fluid">

                <div class="row">
                    <a href="#" class="js-fh5co-nav-toggle fh5co-nav-toggle"><i></i></a>
                    <ul class="fh5co-social">
                        <li>
                            <input id="btnKaydet" type="button" value="Kaydet" class="buton-reg" />
                            <input id="btnCikis" type="button" value="Çıkış" class="buton-reg" />
                           

                        </li>
                    </ul>
                    <div class="col-lg-12 col-md-12 text-center">
                        <h1 id="fh5co-logo"><a href="index.aspx">Selçuk <sup>TM</sup></a></h1>
                    </div>


                </div>

            </div>
        </form>
    </header>
    <!-- END #fh5co-header -->

    <div class="container-fluid">
        <div class="row fh5co-post-entry">
        </div>

    </div>

    <footer id="fh5co-footer">
        <p>
            <small>&copy; 2016. Magazine Free HTML5. All Rights Reserverd.
            <br>
                Designed by <a href="http://freehtml5.co" target="_blank">FREEHTML5.co</a>  Demo Images: <a href="http://unsplash.com/" target="_blank">Unsplash</a></small>
        </p>
    </footer>



    <!-- jQuery -->
    <script src="js/jquery.min.js"></script>
    <!-- jQuery Easing -->
    <script src="js/jquery.easing.1.3.js"></script>
    <!-- Bootstrap -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Waypoints -->
    <script src="js/jquery.waypoints.min.js"></script>
    <!-- Main JS -->
    <script src="js/main.js"></script>


    <script src="js/dropdownloginindex.js"></script>

</body>
</html>
<script>
    $instagram = $('.fh5co-post-entry');
    $.ajax({
        type: "GET",
        url: "https://api.instagram.com/v1/users/1418297331/media/recent/?access_token=1418297331.1677ed0.fd2c45039d71400bb085fabb5bb07111",
        dataType: "jsonp",
        success: function (json) {
            $(json.data).each(function (e) {

                $instagram.append(
                '<article class="col-lg-3 col-md-3 col-sm-3 col-xs-6 col-xxs-12 animate-box item"> <figure> ' +
                '<img src="' + this.images.low_resolution.url + '" alt="Image" class="img-responsive" /> </figure>' +
                '<input class="admintxt" type="text" name="magaza" value="' + this.user.full_name + '" />' +
                ' <input class="admintxt" type="text" name="magaza" value="' + 2 * 15 + '$ US Dollar"/><input class="admintxt" type="text" name="magaza" value="March 6th, 2016"/><input type="checkbox" name="box1"  value="secim1" title="Güncelle"style="width:20px;height:20px;" /></article>'

                );
            });
        }
    });

    $('#btnKaydet').on('click', function () {

        var InstaData = [];

        var item = $(".fh5co-post-entry .item");

        item.each(function () {
            var postData = {};
            postData.instaImage = $(this).find('img').attr('src');

            InstaData.push(postData);
        });

        console.log(JSON.stringify(InstaData));
        $.ajax({
            type: "POST",
            url: "AdminPanel.aspx",
            data: '{user: ' + JSON.stringify(user) + '}',
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            success: function (response) {
                window.location.reload();
            }

        });
        return false;

    });



</script>

