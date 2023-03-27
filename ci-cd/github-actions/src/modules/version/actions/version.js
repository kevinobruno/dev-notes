const { version } = require('../../../../package.json');

const versionAction = (req, res, next) => {
  res.status(200).send({ version });
  next();
};

module.exports = versionAction;
