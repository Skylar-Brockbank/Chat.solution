setInterval(reloadPartial,1000);

  function reloadPartial()
  {
    var messageWindow = document.getElementById("outerMessageSpace");
    let resetView = (messageWindow.scrollHeight <= messageWindow.scrollTop+messageWindow.clientHeight+50);
    let targetId = $("#idtest").val();
    $("#messageSpace").load(`/LoadMessages/${targetId}`);
    if(resetView)
    {
      messageWindow.scrollTop = messageWindow.scrollHeight;
    }
  }
