$(document).ready(function () {
  let teacherSearch;
  let allTeachers = $("#teacher-list").html();

  $("#teacher-search-input").keyup(function () {
    teacherSearch = $(this).val().trim();
    $("#teacher-list #teacher-card").remove();
    if (teacherSearch.length == 0) {
      $("#teacher-list").append(allTeachers);
      return;
    }

    $.ajax({
      url: `Teacher/Search?search=${teacherSearch}`,
      type: 'GET',
      success: function (res) {
        $("#teacher-list").append(res);
      }
    })
  })

  let blogSearch;
  let allBlogs = $("#blog-list").html();

  $("#blog-search-input").keyup(function () {
    blogSearch = $(this).val().trim();
    $("#blog-list #blog-card").remove();
    if (blogSearch.length == 0) {
      return;
    }

    $.ajax({
      url: `Blog/Search?search=${blogSearch}`,
      type: 'GET',
      success: function (res) {
        $("#blog-list").append(res);
      }
    })
  })

  let eventSearch;
  let allEvents = $("#event-list").html();

  $("#event-search-input").keyup(function () {
    eventSearch = $(this).val().trim();
    $("#event-list #event-card").remove();
    if (eventSearch.length == 0) {
      $("#event-list").append(allEvents);
      return;
    }
    $.ajax({
      url: `Event/Search?search=${eventSearch}`,
      type: 'GET',
      success: function (res) {
        $("#event-list").append(res);
      }
    })
  })
}
)
