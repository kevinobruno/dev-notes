const express = require('express');
const app = express();

const versionAction = require('./modules/version/actions/version');

app.get('/version', versionAction);

app.listen(3999, () => console.log('Server listening on port 3999'));
