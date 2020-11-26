<%@ Page Title="Welcome!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_shop_books._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>!!</h1>
        <h3>Internet Archive</h3>
        <p class="lead">Internet Archive is a non-profit library of millions of free books, movies, software, music, websites, and more.</p>

    <div class="jumbotron">
        <h1>LibriVox</h1>
        <p class="lead">The LibriVox Free Audiobook Collection</p>
        <p><a href="https://archive.org/details/librivoxaudio" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Community Video</h2>
            <p>
                You are invited to view or upload your videos to the Community collection. These thousands of videos were contributed by Archive users and community members. These videos are available for free download.
            <p>
                <a class="btn btn-default" href="https://archive.org/details/opensource_movies">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Community Texts</h2>
            <p>
                These books are books contributed by the community.
            </p>
            <p>
                <a class="btn btn-default" href="https://archive.org/details/opensource">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Community Audio</h2>
            <p>
                You are invited to view or upload audios to the Community collection. These thousands of recordings were all contributed by Archive users and community members.
            </p>
            <p>
                <a class="btn btn-default" href="https://archive.org/details/opensource_audio">Learn more &raquo;</a>
            </p>
        </div>
    </div>
    
</asp:Content>
