export default function QuestionPost(releaseTaskId) {
    return `
    <div class="questionpostcomponent"
    <h4><b>Enter the Question details below.<b></h4><br><br>
    <button class="add-question__submit" id="${releaseTaskId}">Save</button>
    <button class="edit__releaseTaskButton__back" id=${releaseTaskId}>Back</button><br><br>
    <input class="edit-releaseTask__id" hidden="true" value="${releaseTaskId}">
    <textarea rows="4" cols="50" <input class="add-question__details" type="text" placeholder="Add Question Here"></textarea>
    </div>

    `
}