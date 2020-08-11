import apiActions from './api/apiActions';
import SelectDropDownID from './components/SelectDropDownID';
import HandleTaskRows from './components/HandleTaskRows';
import HandleDropDowns from './components/HandleDropDowns';
import Reminders from './components/Reminders';
//import ActiveTasks from './components/ActiveTasks';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
import ReleaseTaskEdit from './components/ReleaseTaskEdit';
import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
// import Footer from './components/Footer';
import CommentPost from './components/CommentPost';
import HomePage from './components/HomePage';
import Sort from './components/Sort';
import moment from "moment";
import swal from 'sweetalert';

const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
let currentSelectedRowID = 1;
var AppTimer = null;
let nameSortOrder = "ascending";
let statusSortOrder = "ascending";
let prioritySortOrder = "ascending";
let employeeSortOrder = "ascending";
let dueTimeSortOrder = "ascending";
let idSortOrder = "descending";

let currActiveReleaseTasks = null;

export default function pagebuild() {
    header()
    // footer()
    //navHome()
    //showReleaseTasks();
    StartApp();

    //TODO:  Uncomment the following line before demos and final release
    //AppTimer = setInterval(ExecuteTimer,15000);    
}

function header() {
    const header = document.querySelector('.header');
    header.innerHTML = Header();
}
// function footer() {
//     const footerElement = document.querySelector('.footer');
//     footerElement.innerHTML = Footer();
// }

// function navHome() {
//     const homeButton = document.querySelector('.nav__home');
//     homeButton.addEventListener('click', function () {
//         console.log('navhome');
//         appDiv.innerHTML = showReleaseTasks();
//     })
// }

function StartApp(){

    appDivLeft.innerHTML = HomePage();
}

appDivLeft.addEventListener('click', function () {
    if (event.target.parentElement.classList.contains('startapp')) {
        console.log('start app clicked');
        showReleaseTasks();
    }
})

appDivLeft.addEventListener('click', function () {
    
    if (event.target.classList.contains('table_header__ID')){
        //idSortOrder = Sort.ID(idSortOrder);
        currActiveReleaseTasks.sort((a,b) => (a.id < b.id) ? 1: -1);
        appDivLeft.innerHTML = ReleaseTasks(currActiveReleaseTasks);

        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);

    }
})

appDivLeft.addEventListener('click', function () {
    
    if (event.target.classList.contains('table_header__Name')){
        nameSortOrder = Sort.Name(nameSortOrder);
        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function() {
    if (event.target.classList.contains('table_header__Status')){
        statusSortOrder = Sort.Status(statusSortOrder);
        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function() {
    if (event.target.classList.contains('table_header__Priority')){
        prioritySortOrder = Sort.Priority(prioritySortOrder);
        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function() {
    if (event.target.classList.contains('table_header__AssignedTo')){
        employeeSortOrder = Sort.Employee(employeeSortOrder);
        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function() {
    if (event.target.classList.contains('table_header__DueTime')){
        dueTimeSortOrder = Sort.DueTime(dueTimeSortOrder);
        currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

function showReleaseTasks() {

    fetch("https://localhost:44302/api/releaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
            appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
            currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
            HandleTaskRows.highlightSpecificRow(1);
            currActiveReleaseTasks = releaseTasks;
        })
        .catch(err => console.log(err))

    console.log('before array call');

    const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
    const releaseTaskCallback = releaseTask => {
        appDivRight.innerHTML = ReleaseTask(releaseTask);
    };
    apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    console.log('in show tasks'+currentSelectedRowID);

}


appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('delete_releaseTaskButton')) {
        const releaseTaskId = event.target.parentElement.querySelector('.delete_releaseTaskButton').id;
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

        if (event.shiftKey){
            var response = confirm("Click OK to PERMINENTLY delete this task?");
            if (response == true){
                apiActions.deleteRequest2(
                    releaseTaskEndpoint
                )
                alert('Task Deleted');
            }
        }
        else {

            const releaseEdit = {
                id: releaseTaskId,
                IsVisisble: false
            };

            var response = confirm("Click OK to delete this task?");
        
            if (response == true){

                apiActions.patchRequest(
                    releaseTaskEndpoint,
                    releaseEdit
                )
                alert('Task Deleted');
            }
        }
        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
                HandleTaskRows.highlightSpecificRow(1);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskEndpoint2 = `https://localhost:44302/api/releaseTask/1`;

        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint2, releaseTaskCallback);
        console.log('indeletetask'+currentSelectedRowID);
        
    }

})


appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit__releaseTaskButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton').id;
        const statusDrop = HandleDropDowns.StatusDropDown();
        const priorityDrop = HandleDropDowns.PriorityDropDown();
        const employeeDrop = HandleDropDowns.EmployeeDropDown();

        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTaskEdit => {
                console.log(releaseTaskEdit.currentDueTime);
                ReleaseTaskEditSection.innerHTML = ReleaseTaskEdit(releaseTaskEdit,statusDrop,priorityDrop,employeeDrop);
                SelectDropDownID.selectElement('statusDropID',releaseTaskEdit.currentStatusID);
                SelectDropDownID.selectElement('priorityDropID',releaseTaskEdit.currentPriorityID);
                SelectDropDownID.selectElement('employeeDropID',releaseTaskEdit.assignedEmployeeID);
            }
        )
        console.log('in edit task'+currentSelectedRowID);

    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit-releaseTask__submit')) {
        const releaseTaskId = event.target.parentElement.querySelector('.edit-releaseTask__id').value;
        const name = event.target.parentElement.querySelector('.edit-releaseTask__name').value;
        const description = event.target.parentElement.querySelector('.new').value;
        const createdDate = event.target.parentElement.querySelector('.edit-releaseTask__createdDate').value;
        const currentDueTime = event.target.parentElement.querySelector('.edit-releaseTask__currentDueTime').value;
        const newStatusID = event.target.parentElement.querySelector('.edit-releaseTask__Status').value;
        const newPriorityID = event.target.parentElement.querySelector('.edit-releaseTask__Priority').value;
        const newEmployeeID = event.target.parentElement.querySelector('.edit-releaseTask__Employee').value;
        var lastModifiedDate = new Date();
        const formatedDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        const releaseEdit = {
            id: releaseTaskId,
            Name: name,
            Description: description,
            CurrentDueTime: currentDueTime,
            IsVisisble: true,
            LastModifiedDate: formatedDate,
            CreatedDate: createdDate,
            CurrentStatusID: newStatusID,
            CurrentPriorityID: newPriorityID,
            AssignedEmployeeID: newEmployeeID
        };

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        apiActions.putRequest2(
            releaseTaskEndpoint,
            releaseEdit
        )

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        //swal("Changes Saved", "", "success");
        alert('Changes Saved');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
                console.log('line 193='+currentSelectedRowID);
                HandleTaskRows.highlightSpecificRow(currentSelectedRowID);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        console.log('in edit save'+currentSelectedRowID);

    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.parentElement.classList.contains('add__releaseTaskButton')) {
        console.log("new task clicked")
        console.log('in add task'+currentSelectedRowID);
        const statusDrop = HandleDropDowns.StatusDropDown();
        const priorityDrop = HandleDropDowns.PriorityDropDown();
        const employeeDrop = HandleDropDowns.EmployeeDropDown();
        const currentDate = new Date();
        const formatedDate = moment(currentDate).format('YYYY-MM-DDTh:mm');
        
        console.log(currentDate);
        console.log(formatedDate);
        appDivRight.innerHTML = ReleaseTaskPostSection(statusDrop, priorityDrop, employeeDrop, currentSelectedRowID, formatedDate);
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('create-releaseTask__submit')) {
        let name = event.target.parentElement.querySelector('.create-releaseTask__name').value;
        const description = event.target.parentElement.querySelector('.create-releaseTask__description').value;
        const currentDueTime = event.target.parentElement.querySelector('.create-releaseTask__currentDueTime').value;
        const currentStatusID = event.target.parentElement.querySelector('.create-releaseTask__Status').value;
        const currentPriorityID = event.target.parentElement.querySelector('.create-releaseTask__Priority').value;
        const assignedEmployeeID = event.target.parentElement.querySelector('.create-releaseTask__Employee').value;
        var lastModifiedDate = new Date();
        const formatedCurrentDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        name = name.charAt(0).toUpperCase() + name.slice(1);
        var requestBody = {
            Name: name,
            Description: description,
            CreatedDate:formatedCurrentDate,
            IsVisisble: true,
            CurrentDueTime: currentDueTime,
            LastModifiedDate: formatedCurrentDate,
            CurrentStatusID: currentStatusID,
            CurrentPriorityID: currentPriorityID,
            AssignedEmployeeID: assignedEmployeeID,
        }
        console.log(requestBody)
        apiActions.postRequest(
            "https://localhost:44302/api/releaseTask",
            requestBody,
            newReleaseTasks => {
                appDivLeft.innerHTML = ReleaseTasks(newReleaseTasks);
            }
        )

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        alert('Task Added');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
                console.log('in Add Task fetch, current row='+currentSelectedRowID);
                HandleTaskRows.highlightSpecificRow(1);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        //TODO:  Since we don't have an ID (from SQL) for this add we need to default it to 1
        //          so that the display still works with the table row highlighted with the
        //          task details being displayed.  If we have time to conver to a 'Release Task Number'
        //          instead of the SQL ID we could then highlight the newly added row
        //const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    }
})

appDivRight.addEventListener('click', function(releaseTask){
    if (event.target.classList.contains('edit__releaseTaskButton__back')){
        console.log('in back'+currentSelectedRowID);

        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton__back').id;
        console.log('in back2='+releaseTaskId);
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            }
        )
    }           
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('add__commentButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.add__commentButton').id;
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            addComment => {
                ReleaseTaskEditSection.innerHTML = CommentPost(releaseTaskId, addComment);
            }
        )
        console.log('in add comment'+currentSelectedRowID);

    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('add-comment__submit')) {
        console.log('in save comment');
        const releaseTaskId = event.target.parentElement.querySelector('.add-comment__submit').id;
        const isVisible = true;
        const commentDetails = event.target.parentElement.querySelector('.add-comment__details').value;
        console.log(releaseTaskId);
        console.log(isVisible);
        console.log(commentDetails);

        const newCommentBody = {
            Details: commentDetails,
            IsVisible: isVisible,
            ReleaseTaskID: releaseTaskId
        }

        console.log(newCommentBody);

        apiActions.postRequest2(
            "https://localhost:44302/api/comment",
            newCommentBody
            )

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        alert('Changes Saved');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
                console.log('in submit comment'+currentSelectedRowID);
                HandleTaskRows.highlightSpecificRow(currentSelectedRowID);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        console.log('bottom submit comment'+currentSelectedRowID);


    }
})

function ExecuteTimer(){

    const tasks = Reminders.TasksArray();
    console.log(tasks);
    tasks.sort((a,b) => (a.id < b.id) ? 1: -1);
    console.log(tasks);
    tasks.forEach(element => {
        let curr = (new Date(element.currentDueTime));
        let now = (new Date());
        if (curr < now){
            alert('Warning.  The following task is overdue\n\n'+element.name);
        }
    });

    const activeTasks = ActiveTasks.ActiveTasksArray();
    console.log(activeTasks);
    tasks.sort((a,b) => (a.id < b.id) ? 1: -1);
    console.log(activeTasks);

}

appDivLeft.addEventListener('click', function(){

    if (event.target.parentElement.classList.contains('reminders__button')) {
        if (event.shiftKey){
            fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                //releaseTasks = releaseTasks.filter(task => task.isVisisble == true);

                appDivRight.innerHTML = ReleaseTasks(releaseTasks);
                //currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
                //HandleTaskRows.highlightSpecificRow(1);
            })
            .catch(err => console.log(err))
        }
        else {
            ExecuteTimer();
        }
        
    }
})
