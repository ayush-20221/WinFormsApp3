import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';

const app = express();
const port = 3000;
const dbFilePath = './db.json';

app.use(bodyParser.json());

app.get('/ping', (req: Request, res: Response) => {
    res.json(true);
});

app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const newSubmission = { name, email, phone, github_link, stopwatch_time };

    fs.readFile(dbFilePath, 'utf8', (err, data) => {
        if (err) return res.status(500).send('Error reading database');
        const db = JSON.parse(data);
        db.submissions.push(newSubmission);
        fs.writeFile(dbFilePath, JSON.stringify(db), 'utf8', err => {
            if (err) return res.status(500).send('Error writing to database');
            res.status(201).send('Submission saved');
        });
    });
});

app.get('/submissions', (req: Request, res: Response) => {
    fs.readFile(dbFilePath, 'utf8', (err, data) => {
        if (err) return res.status(500).send('Error reading database');
        const db = JSON.parse(data);
        res.json(db.submissions);
    });
});

app.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    fs.readFile(dbFilePath, 'utf8', (err, data) => {
        if (err) return res.status(500).send('Error reading database');
        const db = JSON.parse(data);
        if (index >= 0 && index < db.submissions.length) {
            res.json(db.submissions[index]);
        } else {
            res.status(404).send('Submission not found');
        }
    });
});

app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}/`);
});
