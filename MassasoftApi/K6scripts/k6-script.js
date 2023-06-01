import http from 'k6/http';
import { check } from 'k6';

export let options = {
    stages: [
        { duration: '10s', target: 20 },
        { duration: '10s', target: 20 },
        { duration: '10s', target: 0 },
    ],
};

export default function () {
    const url = 'http://localhost:7077/about';

    const payload = JSON.stringify({
        sender: 'test@example.com',
        subject: 'Test Subject',
        message: 'Test Message',
    });

    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    const response = http.post(url, payload, params);

    check(response, {
        'Status is 200': (r) => r.status === 200,
        'Response contains expected data': (r) => r.body.includes('expected data'),
    });
}
