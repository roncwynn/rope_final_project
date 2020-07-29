// import Employee from './components/Employee';
// import Priority from './components/Priority';
// import Status from './components/Status';
import ApiActions from './api/apiActions';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
// import ReleaseTaskEdit from './components/ReleaseTaskEdit';
// import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
// import Footer from './components/Footer';


const appDiv = document.querySelector('.app');

export default function pagebuild(){
    header()
    // footer()
    // home()
    showReleaseTasks();
    releaseTaskNameButton();
    // showStatus()
    // showPriority()    
}

function header() {
    const header = document.querySelector('.header');
    header.innerHTML = Header();
}
// function footer() {
//     const footerElement = document.querySelector('.footer');
//     footerElement.innerHTML = Footer();
// }
function showReleaseTasks() {
    console.log(appDiv);
    fetch("https://localhost:44302/api/releaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            appDiv.innerHTML = ReleaseTasks(releaseTasks);
        })
        .catch(err => console.log(err))
}
function releaseTaskNameButton() {
    const releaseTaskItem = document.querySelector('.releaseTask__name');
    console.log("release Task item ="+releaseTaskItem)
    releaseTaskItem.forEach(element => {
        element.addEventListener('click', function () {
            const releaseTaskId = element.id;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {
                appDiv.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskCallback, releaseTaskEndpoint);

        })
    })
}

// function showEmployeeList() {
//     fetch()
//         .then(response => response.json())
//         .then(employees => {
//             appDiv.innerHTML = Employees(employees);
//         })
//         .catch(err => console.log(err))
// }
// function showReleaseTask_ByPriority() {
//     const priorityReleaseTask = document.querySelectorAll(".releaseTask__item");
//     priorityReleaseTask.forEach(element => {
//         element.addEventListener('click', function () {
//             const priorityReleaseTaskId = element.id;
//             fetch()
//                 .then(response => response.json())
//                 .then( => appDiv.innerHTML = )
//                 .catch(err => console.log(err))
//         })
//     })

// }
